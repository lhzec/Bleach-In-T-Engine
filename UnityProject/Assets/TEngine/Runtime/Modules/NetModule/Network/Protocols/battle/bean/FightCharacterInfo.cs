using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 战斗角色信息
 */
public class FightCharacterInfo : IMessageSerialize 
{
	//战斗技能统计
	List<FightSkillStat> _skillStat = new List<FightSkillStat>();
	//id
	int _characterId;	
	//剩余血量
	int _hp;	
	//攻击
	int _atk;	
	//防御
	int _defence;	
	//累计输出
	int _totalDamage;	
	//普通攻击最大单次伤害
	int _maxDamage;	
	//最大单次伤害敌方ID
	int _maxDamageEnemyId;	
	//最大血量
	int _maxHp;	
	//最大蓝量
	int _maxMp;	
	//单次最高伤害时，自己身上的buff列表
	List<int> _selfBuffIds = new List<int>();
	//单次最高伤害时，敌方身上的buff列表
	List<int> _enemyBuffIds = new List<int>();
	//受伤总量
	int _totalInjury;	
	//恢复总量
	int _totalRecovery;	
	//蓝耗总量
	int _totalMpCost;	
	//蓝恢复总量
	int _totalMpRecovery;	
	//剩余静血
	int _staticHp;	
	//最大静血
	int _maxStaticHp;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//战斗技能统计
		SerializeUtils.WriteShort(stream, (short)_skillStat.Count);

		foreach (var element in _skillStat)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//id
		SerializeUtils.WriteInt(stream, _characterId);
		//剩余血量
		SerializeUtils.WriteInt(stream, _hp);
		//攻击
		SerializeUtils.WriteInt(stream, _atk);
		//防御
		SerializeUtils.WriteInt(stream, _defence);
		//累计输出
		SerializeUtils.WriteInt(stream, _totalDamage);
		//普通攻击最大单次伤害
		SerializeUtils.WriteInt(stream, _maxDamage);
		//最大单次伤害敌方ID
		SerializeUtils.WriteInt(stream, _maxDamageEnemyId);
		//最大血量
		SerializeUtils.WriteInt(stream, _maxHp);
		//最大蓝量
		SerializeUtils.WriteInt(stream, _maxMp);
		//单次最高伤害时，自己身上的buff列表
		SerializeUtils.WriteShort(stream, (short)_selfBuffIds.Count);

		foreach (var element in _selfBuffIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//单次最高伤害时，敌方身上的buff列表
		SerializeUtils.WriteShort(stream, (short)_enemyBuffIds.Count);

		foreach (var element in _enemyBuffIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//受伤总量
		SerializeUtils.WriteInt(stream, _totalInjury);
		//恢复总量
		SerializeUtils.WriteInt(stream, _totalRecovery);
		//蓝耗总量
		SerializeUtils.WriteInt(stream, _totalMpCost);
		//蓝恢复总量
		SerializeUtils.WriteInt(stream, _totalMpRecovery);
		//剩余静血
		SerializeUtils.WriteInt(stream, _staticHp);
		//最大静血
		SerializeUtils.WriteInt(stream, _maxStaticHp);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//战斗技能统计
		int _skillStat_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _skillStat_length; ++i) 
		{
			_skillStat.Add(SerializeUtils.ReadBean<FightSkillStat>(stream));
		}
		//id
		_characterId = SerializeUtils.ReadInt(stream);
		//剩余血量
		_hp = SerializeUtils.ReadInt(stream);
		//攻击
		_atk = SerializeUtils.ReadInt(stream);
		//防御
		_defence = SerializeUtils.ReadInt(stream);
		//累计输出
		_totalDamage = SerializeUtils.ReadInt(stream);
		//普通攻击最大单次伤害
		_maxDamage = SerializeUtils.ReadInt(stream);
		//最大单次伤害敌方ID
		_maxDamageEnemyId = SerializeUtils.ReadInt(stream);
		//最大血量
		_maxHp = SerializeUtils.ReadInt(stream);
		//最大蓝量
		_maxMp = SerializeUtils.ReadInt(stream);
		//单次最高伤害时，自己身上的buff列表
		int _selfBuffIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _selfBuffIds_length; ++i) 
		{
			_selfBuffIds.Add(SerializeUtils.ReadInt(stream));
		}
		//单次最高伤害时，敌方身上的buff列表
		int _enemyBuffIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _enemyBuffIds_length; ++i) 
		{
			_enemyBuffIds.Add(SerializeUtils.ReadInt(stream));
		}
		//受伤总量
		_totalInjury = SerializeUtils.ReadInt(stream);
		//恢复总量
		_totalRecovery = SerializeUtils.ReadInt(stream);
		//蓝耗总量
		_totalMpCost = SerializeUtils.ReadInt(stream);
		//蓝恢复总量
		_totalMpRecovery = SerializeUtils.ReadInt(stream);
				//剩余静血
		_staticHp = SerializeUtils.ReadInt(stream);
		//最大静血
		_maxStaticHp = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 战斗技能统计
	 * @return 
	 */
	public List<FightSkillStat> GetSkillStat()
	{
		return _skillStat;
	}
	
	/**
	 * set 战斗技能统计
	 */
	public void SetSkillStat(List<FightSkillStat> skillStat)
	{
		_skillStat = skillStat;
	}
	
	/**
	 * id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 剩余血量
	 */
	public int Hp
	{
		set { _hp = value; }
	    get { return _hp; }
	}
	
	/**
	 * 攻击
	 */
	public int Atk
	{
		set { _atk = value; }
	    get { return _atk; }
	}
	
	/**
	 * 防御
	 */
	public int Defence
	{
		set { _defence = value; }
	    get { return _defence; }
	}
	
	/**
	 * 累计输出
	 */
	public int TotalDamage
	{
		set { _totalDamage = value; }
	    get { return _totalDamage; }
	}
	
	/**
	 * 普通攻击最大单次伤害
	 */
	public int MaxDamage
	{
		set { _maxDamage = value; }
	    get { return _maxDamage; }
	}
	
	/**
	 * 最大单次伤害敌方ID
	 */
	public int MaxDamageEnemyId
	{
		set { _maxDamageEnemyId = value; }
	    get { return _maxDamageEnemyId; }
	}
	
	/**
	 * 最大血量
	 */
	public int MaxHp
	{
		set { _maxHp = value; }
	    get { return _maxHp; }
	}
	
	/**
	 * 最大蓝量
	 */
	public int MaxMp
	{
		set { _maxMp = value; }
	    get { return _maxMp; }
	}
	
	/**
	 * get 单次最高伤害时，自己身上的buff列表
	 * @return 
	 */
	public List<int> GetSelfBuffIds()
	{
		return _selfBuffIds;
	}
	
	/**
	 * set 单次最高伤害时，自己身上的buff列表
	 */
	public void SetSelfBuffIds(List<int> selfBuffIds)
	{
		_selfBuffIds = selfBuffIds;
	}
	
	/**
	 * get 单次最高伤害时，敌方身上的buff列表
	 * @return 
	 */
	public List<int> GetEnemyBuffIds()
	{
		return _enemyBuffIds;
	}
	
	/**
	 * set 单次最高伤害时，敌方身上的buff列表
	 */
	public void SetEnemyBuffIds(List<int> enemyBuffIds)
	{
		_enemyBuffIds = enemyBuffIds;
	}
	
	/**
	 * 受伤总量
	 */
	public int TotalInjury
	{
		set { _totalInjury = value; }
	    get { return _totalInjury; }
	}
	
	/**
	 * 恢复总量
	 */
	public int TotalRecovery
	{
		set { _totalRecovery = value; }
	    get { return _totalRecovery; }
	}
	
	/**
	 * 蓝耗总量
	 */
	public int TotalMpCost
	{
		set { _totalMpCost = value; }
	    get { return _totalMpCost; }
	}
	
	/**
	 * 蓝恢复总量
	 */
	public int TotalMpRecovery
	{
		set { _totalMpRecovery = value; }
	    get { return _totalMpRecovery; }
	}
	
	/**
	 * 剩余静血
	 */
	public int StaticHp
	{
		set { _staticHp = value; }
	    get { return _staticHp; }
	}
	
	/**
	 * 最大静血
	 */
	public int MaxStaticHp
	{
		set { _maxStaticHp = value; }
	    get { return _maxStaticHp; }
	}
}