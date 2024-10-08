using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 战斗结果信息
 */
public class FightResultInfo : IMessageSerialize 
{
	//自己出战角色信息
	List<FightCharacterInfo> _playerInfo = new List<FightCharacterInfo>();
	//对手角色信息
	List<FightCharacterInfo> _enemyInfo = new List<FightCharacterInfo>();
	//非战斗序号：负 战斗序号：胜
	int _success;	
	//战斗耗时（秒）
	int _battleTime;	
	//暂停耗时（秒）
	int _pauseTime;	
	//玩家伤害累计值
	int _hurt;	
	//破防次数
	int _disrupt;	
	//最大连击次数
	int _combo;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//自己出战角色信息
		SerializeUtils.WriteShort(stream, (short)_playerInfo.Count);

		foreach (var element in _playerInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//对手角色信息
		SerializeUtils.WriteShort(stream, (short)_enemyInfo.Count);

		foreach (var element in _enemyInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//非战斗序号：负 战斗序号：胜
		SerializeUtils.WriteInt(stream, _success);
		//战斗耗时（秒）
		SerializeUtils.WriteInt(stream, _battleTime);
		//暂停耗时（秒）
		SerializeUtils.WriteInt(stream, _pauseTime);
		//玩家伤害累计值
		SerializeUtils.WriteInt(stream, _hurt);
		//破防次数
		SerializeUtils.WriteInt(stream, _disrupt);
		//最大连击次数
		SerializeUtils.WriteInt(stream, _combo);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//自己出战角色信息
		int _playerInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _playerInfo_length; ++i) 
		{
			_playerInfo.Add(SerializeUtils.ReadBean<FightCharacterInfo>(stream));
		}
		//对手角色信息
		int _enemyInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _enemyInfo_length; ++i) 
		{
			_enemyInfo.Add(SerializeUtils.ReadBean<FightCharacterInfo>(stream));
		}
		//非战斗序号：负 战斗序号：胜
		_success = SerializeUtils.ReadInt(stream);
		//战斗耗时（秒）
		_battleTime = SerializeUtils.ReadInt(stream);
		//暂停耗时（秒）
		_pauseTime = SerializeUtils.ReadInt(stream);
		//玩家伤害累计值
		_hurt = SerializeUtils.ReadInt(stream);
		//破防次数
		_disrupt = SerializeUtils.ReadInt(stream);
		//最大连击次数
		_combo = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 自己出战角色信息
	 * @return 
	 */
	public List<FightCharacterInfo> GetPlayerInfo()
	{
		return _playerInfo;
	}
	
	/**
	 * set 自己出战角色信息
	 */
	public void SetPlayerInfo(List<FightCharacterInfo> playerInfo)
	{
		_playerInfo = playerInfo;
	}
	
	/**
	 * get 对手角色信息
	 * @return 
	 */
	public List<FightCharacterInfo> GetEnemyInfo()
	{
		return _enemyInfo;
	}
	
	/**
	 * set 对手角色信息
	 */
	public void SetEnemyInfo(List<FightCharacterInfo> enemyInfo)
	{
		_enemyInfo = enemyInfo;
	}
	
	/**
	 * 非战斗序号：负 战斗序号：胜
	 */
	public int Success
	{
		set { _success = value; }
	    get { return _success; }
	}
	
	/**
	 * 战斗耗时（秒）
	 */
	public int BattleTime
	{
		set { _battleTime = value; }
	    get { return _battleTime; }
	}
	
	/**
	 * 暂停耗时（秒）
	 */
	public int PauseTime
	{
		set { _pauseTime = value; }
	    get { return _pauseTime; }
	}
	
	/**
	 * 玩家伤害累计值
	 */
	public int Hurt
	{
		set { _hurt = value; }
	    get { return _hurt; }
	}
	
	/**
	 * 破防次数
	 */
	public int Disrupt
	{
		set { _disrupt = value; }
	    get { return _disrupt; }
	}
	
	/**
	 * 最大连击次数
	 */
	public int Combo
	{
		set { _combo = value; }
	    get { return _combo; }
	}
	
}