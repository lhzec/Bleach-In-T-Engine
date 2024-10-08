using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 灵魂共鸣属性
 */
public class GlobalBattleAttributeInfo : IMessageSerialize 
{
	//最终伤害
	int _finalDamagePct;	
	//最终减伤
	int _finalMitigationPct;	
	//技能1威力
	int _skill1DamagePct;	
	//技能2威力
	int _skill2DamagePct;	
	//技能3威力
	int _skill3DamagePct;	
	//技能冷却时间
	int _skillCDPct;	
	//施放者影响Buff持续时间增益
	int _casterAffectBuffDurationPct;	
	//施放者影响Debuff持续时间增益
	int _casterAffectDebuffDurationPct;	
	//宿主影响Buff持续时间增益
	int _acceptorAffectBuffDurationPct;	
	//宿主影响Debuff持续时间增益
	int _acceptorAffectDebuffDurationPct;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//最终伤害
		SerializeUtils.WriteInt(stream, _finalDamagePct);
		//最终减伤
		SerializeUtils.WriteInt(stream, _finalMitigationPct);
		//技能1威力
		SerializeUtils.WriteInt(stream, _skill1DamagePct);
		//技能2威力
		SerializeUtils.WriteInt(stream, _skill2DamagePct);
		//技能3威力
		SerializeUtils.WriteInt(stream, _skill3DamagePct);
		//技能冷却时间
		SerializeUtils.WriteInt(stream, _skillCDPct);
		//施放者影响Buff持续时间增益
		SerializeUtils.WriteInt(stream, _casterAffectBuffDurationPct);
		//施放者影响Debuff持续时间增益
		SerializeUtils.WriteInt(stream, _casterAffectDebuffDurationPct);
		//宿主影响Buff持续时间增益
		SerializeUtils.WriteInt(stream, _acceptorAffectBuffDurationPct);
		//宿主影响Debuff持续时间增益
		SerializeUtils.WriteInt(stream, _acceptorAffectDebuffDurationPct);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//最终伤害
		_finalDamagePct = SerializeUtils.ReadInt(stream);
		//最终减伤
		_finalMitigationPct = SerializeUtils.ReadInt(stream);
		//技能1威力
		_skill1DamagePct = SerializeUtils.ReadInt(stream);
		//技能2威力
		_skill2DamagePct = SerializeUtils.ReadInt(stream);
		//技能3威力
		_skill3DamagePct = SerializeUtils.ReadInt(stream);
		//技能冷却时间
		_skillCDPct = SerializeUtils.ReadInt(stream);
		//施放者影响Buff持续时间增益
		_casterAffectBuffDurationPct = SerializeUtils.ReadInt(stream);
		//施放者影响Debuff持续时间增益
		_casterAffectDebuffDurationPct = SerializeUtils.ReadInt(stream);
		//宿主影响Buff持续时间增益
		_acceptorAffectBuffDurationPct = SerializeUtils.ReadInt(stream);
		//宿主影响Debuff持续时间增益
		_acceptorAffectDebuffDurationPct = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 最终伤害
	 */
	public int FinalDamagePct
	{
		set { _finalDamagePct = value; }
	    get { return _finalDamagePct; }
	}
	
	/**
	 * 最终减伤
	 */
	public int FinalMitigationPct
	{
		set { _finalMitigationPct = value; }
	    get { return _finalMitigationPct; }
	}
	
	/**
	 * 技能1威力
	 */
	public int Skill1DamagePct
	{
		set { _skill1DamagePct = value; }
	    get { return _skill1DamagePct; }
	}
	
	/**
	 * 技能2威力
	 */
	public int Skill2DamagePct
	{
		set { _skill2DamagePct = value; }
	    get { return _skill2DamagePct; }
	}
	
	/**
	 * 技能3威力
	 */
	public int Skill3DamagePct
	{
		set { _skill3DamagePct = value; }
	    get { return _skill3DamagePct; }
	}
	
	/**
	 * 技能冷却时间
	 */
	public int SkillCDPct
	{
		set { _skillCDPct = value; }
	    get { return _skillCDPct; }
	}
	
	/**
	 * 施放者影响Buff持续时间增益
	 */
	public int CasterAffectBuffDurationPct
	{
		set { _casterAffectBuffDurationPct = value; }
	    get { return _casterAffectBuffDurationPct; }
	}
	
	/**
	 * 施放者影响Debuff持续时间增益
	 */
	public int CasterAffectDebuffDurationPct
	{
		set { _casterAffectDebuffDurationPct = value; }
	    get { return _casterAffectDebuffDurationPct; }
	}
	
	/**
	 * 宿主影响Buff持续时间增益
	 */
	public int AcceptorAffectBuffDurationPct
	{
		set { _acceptorAffectBuffDurationPct = value; }
	    get { return _acceptorAffectBuffDurationPct; }
	}
	
	/**
	 * 宿主影响Debuff持续时间增益
	 */
	public int AcceptorAffectDebuffDurationPct
	{
		set { _acceptorAffectDebuffDurationPct = value; }
	    get { return _acceptorAffectDebuffDurationPct; }
	}
	
}