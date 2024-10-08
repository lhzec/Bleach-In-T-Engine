using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 角色技能信息
 */
public class FightSkillInfo : IMessageSerialize 
{
	//技能id
	int _skillId;	
	//技能等级
	int _skillLevel;	
	//技能强化系数（援护技）
	int _skillEnhance;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//技能id
		SerializeUtils.WriteInt(stream, _skillId);
		//技能等级
		SerializeUtils.WriteInt(stream, _skillLevel);
		//技能强化系数（援护技）
		SerializeUtils.WriteInt(stream, _skillEnhance);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//技能id
		_skillId = SerializeUtils.ReadInt(stream);
		//技能等级
		_skillLevel = SerializeUtils.ReadInt(stream);
		//技能强化系数（援护技）
		_skillEnhance = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 技能id
	 */
	public int SkillId
	{
		set { _skillId = value; }
	    get { return _skillId; }
	}
	
	/**
	 * 技能等级
	 */
	public int SkillLevel
	{
		set { _skillLevel = value; }
	    get { return _skillLevel; }
	}
	
	/**
	 * 技能强化系数（援护技）
	 */
	public int SkillEnhance
	{
		set { _skillEnhance = value; }
	    get { return _skillEnhance; }
	}
	
}